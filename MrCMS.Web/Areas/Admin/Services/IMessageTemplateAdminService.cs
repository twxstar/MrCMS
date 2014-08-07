using System.Collections.Generic;
using MrCMS.Entities.Messaging;
using MrCMS.Web.Areas.Admin.Models;

namespace MrCMS.Web.Areas.Admin.Services
{
    public interface IMessageTemplateAdminService
    {
        void Save(MessageTemplate messageTemplate);
        List<MessageTemplateInfo> GetAllMessageTemplateTypesWithDetails();
        MessageTemplate GetNew(string type);
        MessageTemplate Reset(MessageTemplate messageTemplate);
        List<string> GetTokens(MessageTemplate messageTemplate);
        T Get<T>() where T : MessageTemplate;
        string GetPreview(MessageTemplate messageTemplate, int itemId);
    }
}