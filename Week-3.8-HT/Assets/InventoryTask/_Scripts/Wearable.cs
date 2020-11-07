using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.InventoryTask._Scripts
{
    public enum TypeOfWearable
    {
        weapon,
        helmet,
        chestplate,
        leggins,
        boots
    }
    [System.Serializable]
    public class Wearable : Item
    {
        public TypeOfWearable typeOfWearable;

        public Wearable(ItemArgs args):base(args)
        {
        }
    }
}
