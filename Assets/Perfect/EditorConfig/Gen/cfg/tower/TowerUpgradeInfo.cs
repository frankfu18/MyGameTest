using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public abstract class TowerUpgradeInfo :   cfg.EditorWriter 
 {

    public cfg.common.Cost upgradeCost ;
     public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> attrs  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     



    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerUpgradeInfo(Perfect.Marshal.Octets os) {

        upgradeCost = cfg.Extensions.unmarshal_cfg_common_Cost(os); 
         attrs = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         
    }

    public TowerUpgradeInfo()
    {
    }

}
}
}
