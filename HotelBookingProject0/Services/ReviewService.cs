using HotelBookingProject0.Constants;
using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.ReviewDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelBookingProject0.Services
{
    public class ReviewService(HotelBookingContext context, UserManager<User> userManager) : IReviewService
    {
        private readonly HotelBookingContext context = context;
        private readonly UserManager<User> userManager = userManager;

        public async Task<ReviewResponseDTO> CreateReviewAsync(string userId, ReviewDTO dto)
        {

            bool alreadyReviewed = await context.Reviews
                .AnyAsync(r => r.UserID == userId && r.HotelID == dto.HotelID);

            if (alreadyReviewed)
                throw new InvalidOperationException("You have already submitted a review for this hotel.");

            bool hotelExists = await context.Hotels.AnyAsync(h => h.HotelID == dto.HotelID);
            if (!hotelExists)
                throw new KeyNotFoundException("Hotel not found.");

            var review = new Review
            {
                UserID = userId,
                HotelID = dto.HotelID,
                Rating = dto.Rating,
                Comment = dto.Comment,
                ReviewDate = DateTime.UtcNow,
                Status = ReviewStatuses.Pending
            };

            context.Reviews.Add(review);
            await context.SaveChangesAsync();

            return await ProjectToDTO(review);
        }

        public async Task<IEnumerable<ReviewResponseDTO>> GetApprovedReviewsByHotelAsync(int hotelId)
        {
            return await context.Reviews
                .Include(r => r.User)
                .Include(r => r.Hotel)
                .Where(r => r.HotelID == hotelId && r.Status == ReviewStatuses.Approved)
                .OrderByDescending(r => r.ReviewDate)
                .Select(r => MapToDTO(r))
                .ToListAsync();
        }

        public async Task<IEnumerable<ReviewResponseDTO>> GetMyReviewsAsync(string userId)
        {
            return await context.Reviews
                .Include(r => r.User)
                .Include(r => r.Hotel)
                .Where(r => r.UserID == userId)
                .OrderByDescending(r => r.ReviewDate)
                .Select(r => MapToDTO(r))
                .ToListAsync();
        }

        public async Task DeleteReviewAsync(int reviewId, string userId)
        {
            var review = await context.Reviews
                .FirstOrDefaultAsync(r => r.ReviewID == reviewId && r.UserID == userId)
                ?? throw new KeyNotFoundException("Review not found.");

            if (review.Status == ReviewStatuses.Approved)
                throw new InvalidOperationException("Approved reviews cannot be deleted.");

            context.Reviews.Remove(review);
            await context.SaveChangesAsync();
        }


        public async Task<IEnumerable<ReviewResponseDTO>> GetAllReviewsAsync()
        {
            return await context.Reviews
                .Include(r => r.User)
                .Include(r => r.Hotel)
                .OrderByDescending(r => r.ReviewDate)
                .Select(r => MapToDTO(r))
                .ToListAsync();
        }

        public async Task<IEnumerable<ReviewResponseDTO>> GetPendingReviewsAsync()
        {
            return await context.Reviews
                .Include(r => r.User)
                .Include(r => r.Hotel)
                .Where(r => r.Status == ReviewStatuses.Pending)
                .OrderBy(r => r.ReviewDate)
                .Select(r => MapToDTO(r))
                .ToListAsync();
        }

        public async Task<ReviewResponseDTO> UpdateReviewStatusAsync(
            int reviewId, string status, string? adminNote)
        {
            var review = await context.Reviews
                .Include(r => r.User)
                .Include(r => r.Hotel)
                .FirstOrDefaultAsync(r => r.ReviewID == reviewId)
                ?? throw new KeyNotFoundException("Review not found.");

            review.Status = status;
            review.AdminNote = adminNote;

            await context.SaveChangesAsync();
            return MapToDTO(review);
        }

        public async Task AdminDeleteReviewAsync(int reviewId)
        {
            var review = await context.Reviews.FindAsync(reviewId)
                ?? throw new KeyNotFoundException("Review not found.");

            context.Reviews.Remove(review);
            await context.SaveChangesAsync();
        }


        private static ReviewResponseDTO MapToDTO(Review r) => new()
        {
            ReviewID = r.ReviewID,
            UserID = r.UserID,
            Username = r.User.UserName ?? string.Empty,
            HotelID = r.HotelID,
            HotelName = r.Hotel.Name,
            Rating = r.Rating,
            Comment = r.Comment,
            ReviewDate = r.ReviewDate,
            Status = r.Status
        };

        private async Task<ReviewResponseDTO> ProjectToDTO(Review review)
        {
            await context.Entry(review).Reference(r => r.User).LoadAsync();
            await context.Entry(review).Reference(r => r.Hotel).LoadAsync();
            return MapToDTO(review);
        }
    }
}

