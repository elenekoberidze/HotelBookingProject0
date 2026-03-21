using HotelBookingProject0.Models.DTO.ReviewDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
   
        public interface IReviewService
        {
            Task<ReviewResponseDTO> CreateReviewAsync(string userId, ReviewDTO dto);
            Task<IEnumerable<ReviewResponseDTO>> GetMyReviewsAsync(string userId);
            Task DeleteReviewAsync(int reviewId, string userId);

            Task<IEnumerable<ReviewResponseDTO>> GetApprovedReviewsByHotelAsync(int hotelId);

            Task<IEnumerable<ReviewResponseDTO>> GetAllReviewsAsync();
            Task<IEnumerable<ReviewResponseDTO>> GetPendingReviewsAsync();
            Task<ReviewResponseDTO> UpdateReviewStatusAsync(int reviewId, string status, string? adminNote);
            Task AdminDeleteReviewAsync(int reviewId);
        }
   
}
