﻿using ZipLink.Infrastructure.Common.Email.Models.EmailViewModels;

namespace ZipLink.Infrastructure.Common.Email.Services;

public interface IEmailSender
{
    Task SendEmailConfirmationAsync(string receiverAddress, string link);
    Task SendChangePasswordRequestAsync(string receiverAddress, string link);
    Task SendChangePasswordConfirmationAsync(string receiverAddress);
    Task SendWelcomeAsync(string receiverAddress);
    Task SendLockedAccountAsync(string receiverAddress);
    Task SendEmailAsync(string email, string subject, string message);

}