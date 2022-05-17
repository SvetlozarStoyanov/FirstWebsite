using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrysisWalkthroughs.Models;

namespace CrysisWalkthroughs.Services
{
    interface IAttachmentDataSample
    {
        Dictionary<string, AttachmentModel> GetAllAttachments();
        AttachmentModel GetAttachmentById(int Id);
        AttachmentModel GetAttachmentByName(string Name);
    }
}
