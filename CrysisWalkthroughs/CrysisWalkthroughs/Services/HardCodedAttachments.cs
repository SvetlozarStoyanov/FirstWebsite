using CrysisWalkthroughs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrysisWalkthroughs.Services
{
    public class HardCodedAttachments : IAttachmentDataSample
    {
        static Dictionary<string, AttachmentModel> attachments = new Dictionary<string, AttachmentModel>();

        public Dictionary<string, AttachmentModel> GetAllAttachments()
        {
            int i = 0;
            if (attachments.Count < 10)
            {
                attachments.Add("Silencer", new AttachmentModel(i++, "Silencer", "It completely silences all of the gunfire from a weapon. It trades this for a great increase in damage drop over distances."));
                attachments.Add("Flashlight", new AttachmentModel(i++, "Flashlight", "Illuminates a small area in front of the user. Visible to enemies."));
                attachments.Add("Laser Pointer", new AttachmentModel(i++, "Laser Pointer", "When attached under the barrel of a weapon, it emits a laser that produces a dot wherever said weapon is pointed, but there is a limited distance that the laser can reach."));
                attachments.Add("Incendiary Ammo", new AttachmentModel(i++, "Incendiary Ammo", "Special ammo for the FY-71 rifle. Deals increased damage. Rare to find."));
                attachments.Add("EMP Grenades", new AttachmentModel(i++, "EMP Grenades", "Special ammo for the FGL40 Grenade Launcher. Explode on impact or when detonated by the user when firing in remote detonation mode. Disable vehicles and nanosuits."));
                attachments.Add("Grenade Launcher", new AttachmentModel(i++, "Grenade Launcher", "Underbarrel grenade launcher. Fires a single grenade before reloading. Explodes on impact."));
                attachments.Add("Tactical Attachment", new AttachmentModel(i++, "Tactical Attachment", "Underbarrel attachment. Fires a dart which renders the enemy unconscious for sixty seconds."));
                attachments.Add("Reflex Sight", new AttachmentModel(i++, "Reflex Sight", "Small device that is put on the top of a gun and has a small red dot in its center."));
                attachments.Add("Assault Scope", new AttachmentModel(i++, "Assault Scope", "Scope that has a large, black crosshair and provides a small zoom when used."));
                attachments.Add("Sniper Scope", new AttachmentModel(i++, "Sniper Scope", "Large Scope meant for sniper rifles. It has two zoom modes 4x and 10x."));
            }
            return attachments;
        }

        public AttachmentModel GetAttachmentById(int Id)
        {
            AttachmentModel attachment = new AttachmentModel();
            return attachments.Where(x => x.Value.Id == Id).FirstOrDefault().Value;
        }

        public AttachmentModel GetAttachmentByName(string Name)
        {
            AttachmentModel attachment = new AttachmentModel();

            attachments.TryGetValue(Name, out attachment);
            return attachment;
        }
    }
}
