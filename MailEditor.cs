using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;

namespace BestOfQueenOfSauce
{
    class MailEditor : IAssetEditor
    {
        private int days;
        private int price;

        public MailEditor(int days, int price)
        {
            this.days = days;
            this.price = price;
        }

        public bool CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Data\\mail");
        }

        public void Edit<T>(IAssetData asset)
        {
            var data = asset.AsDictionary<string, string>().Data;

            data["BestOfQOS.Letter1"] = I18n.BestOfQOS_Letter1().Replace("[days]", days.ToString()).Replace("[price]", price.ToString());

        }
    }
}
