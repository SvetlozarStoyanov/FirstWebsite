using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrysisWalkthroughs.Models
{
    public class WeaponModel
    {
        public WeaponModel()
        {

        }
        public WeaponModel(int id, string name, string description, Dictionary<string, List<string>> attachments)
        {
            Id = id;
            Name = name;
            Description = description;
            AttachmentsAsList = new List<string>();
            GenerateAttachments(attachments);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, List<string>> Attachments { get; set; }
        public List<string> AttachmentsAsList { get; set; }
        public void GenerateAttachments(Dictionary<string, List<string>> inputAttachments)
        {
            if (inputAttachments == null)
                return;
            Attachments = new Dictionary<string, List<string>>();
            foreach (var attachment in inputAttachments)
            {
                Attachments.Add(attachment.Key, attachment.Value);
                AttachmentsAsList.AddRange(attachment.Value);
            }
        }
    }
}
