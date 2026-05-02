using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public abstract class GoodsInfo :   cfg.EditorWriter 
 {

    public int id ;
     public string name  = "";
     public cfg.shop.LimitBuyType limitBuyType ;
     public int maxBuyTimes ;
     public cfg.shop.SellInfo sellInfo ;
     public cfg.shop.CostType cost ;
     



    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public GoodsInfo(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         name = os.ReadString(); 
         limitBuyType = cfg.Extensions.unmarshal_cfg_shop_LimitBuyType(os); 
         maxBuyTimes = os.ReadInt(); 
         sellInfo = cfg.Extensions.unmarshal_cfg_shop_SellInfo(os); 
         cost = cfg.Extensions.unmarshal_cfg_shop_CostType(os); 
         
    }

    public GoodsInfo()
    {
    }

}
}
}
