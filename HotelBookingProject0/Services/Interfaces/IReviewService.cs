using HotelBookingProject0.Models.DTO.ReviewDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
   
        public interface IReviewService
        {
        /// <summary>
        /// This method allows a user to create a review for a hotel.
        /// The review will be saved with a "Pending" status and will require admin approval 
        /// before it becomes visible to other users.
        /// </summary>
        Task<ReviewResponseDTO> CreateReviewAsync(string userId, ReviewDTO dto);
        /// <summary>
        /// This method retrieves all reviews submitted by a specific user.
        /// It allows users to view their own reviews,
        /// </summary>
        Task<IEnumerable<ReviewResponseDTO>> GetMyReviewsAsync(string userId);
        /// <summary>
        /// This method allows a user to delete their own review, but only if the review is still in "Pending" status.
        /// </summary>
        Task DeleteReviewAsync(int reviewId, string userId);
        /// <summary>
        /// This method retrieves all approved reviews for a specific hotel. Only reviews with an "Approved" status will be returned
        /// (reviews that have been approved by an admin).
        /// </summary>
        Task<IEnumerable<ReviewResponseDTO>> GetApprovedReviewsByHotelAsync(int hotelId);
        /// <summary>
        /// These methods are intended for administrative use, allowing admins to manage reviews by viewing all reviews,
        /// </summary>
        Task<IEnumerable<ReviewResponseDTO>> GetAllReviewsAsync();
        /// <summary>
        /// These methods are intended for administrative use, allowing admins to manage reviews by viewing all reviews,
        /// </summary>
        Task<IEnumerable<ReviewResponseDTO>> GetPendingReviewsAsync();
        /// <summary>
        /// This method allows an admin to update the status of a review 
        /// (from "Pending" to "Approved" or "Rejected") and optionally add an admin note explaining the decision.
        /// </summary>
        Task<ReviewResponseDTO> UpdateReviewStatusAsync(int reviewId, string status, string? adminNote);
        /// <summary>
        /// This method allows an admin to delete any review, regardless of its status.
        /// This is intended for cases where a review may violate content guidelines or be inappropriate.
        /// </summary>
        Task AdminDeleteReviewAsync(int reviewId);
        }
   
}
