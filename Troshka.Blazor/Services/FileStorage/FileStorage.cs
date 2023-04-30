using System.Drawing;
using Troshka.Blazor.Configuration;
using Troshka.Blazor.Models;

namespace Troshka.Blazor.Services.FileStorage
{
    public class FileStorage : IFileStorage
    {
        public async Task<ResultModel<bool>> StoreAsync(IFormFile[] files)
        {
            bool validImages = AreFilesImages(files);

            if (!validImages)
            {
                return new ResultModel<bool>
                {
                    IsSuccess = false,
                    Message = MessageConstants.OperationSuccessful,
                    Value = false
                };
            }

            // Store to Azure Blob Storage...

            return new ResultModel<bool>
            {
                IsSuccess = false,
                Message = MessageConstants.OperationSuccessful,
                Value = true
            }; ;
        }

        private bool AreFilesImages(IFormFile[] files)
        {
            bool isValid = true;

            foreach (IFormFile file in files)
            {
                if (!IsImage(file))
                {
                    isValid = false;
                }
            }

            return isValid;
        }
        private bool IsImage(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    throw new ArgumentNullException(nameof(file), "The file is null or empty.");
                }

                // Try to create an image from the file stream
                using (Stream fileStream = file.OpenReadStream())
                {
                    using (Image img = Image.FromStream(fileStream))
                    {
                        // If the image is created successfully, it means the file is an image
                        return true;
                    }
                }
            }
            catch (ArgumentException)
            {
                // If Image.FromStream throws an ArgumentException, the file is not an image
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions appropriately for your use case
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
