using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class BattleRefresh :   cfg.EditorWriter 
 {

    public int id ;
     public int enemyTotalNum ;
     public int enemyRefreshRandomLimit ;
     public int goldAdd ;
     public int exploreAdd ;
     public System.Collections.Generic.List<cfg.battle.RefreshWave> refreshContent  = new System.Collections.Generic.List<cfg.battle.RefreshWave>();
     



    public const int TYPE_ID = 55645;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleRefresh(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         enemyTotalNum = os.ReadInt(); 
         enemyRefreshRandomLimit = os.ReadInt(); 
         goldAdd = os.ReadInt(); 
         exploreAdd = os.ReadInt(); 
         refreshContent = cfg.Extensions.unmarshal_list_cfg_battle_RefreshWave(os); 
         
    }

    public BattleRefresh()
    {
    }

    public BattleRefresh(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "enemyTotalNum":  enemyTotalNum = ele.ReadInt(); break; 
             case "enemyRefreshRandomLimit":  enemyRefreshRandomLimit = ele.ReadInt(); break; 
             case "goldAdd":  goldAdd = ele.ReadInt(); break; 
             case "exploreAdd":  exploreAdd = ele.ReadInt(); break; 
             case "refreshContent":  refreshContent = cfg.Extensions.xml_unmarshal_list_cfg_battle_RefreshWave(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BattleRefresh");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("enemyTotalNum"); ele.WriteInt(enemyTotalNum); ele.WriteEndElement();
         ele.WriteStartElement("enemyRefreshRandomLimit"); ele.WriteInt(enemyRefreshRandomLimit); ele.WriteEndElement();
         ele.WriteStartElement("goldAdd"); ele.WriteInt(goldAdd); ele.WriteEndElement();
         ele.WriteStartElement("exploreAdd"); ele.WriteInt(exploreAdd); ele.WriteEndElement();
         ele.WriteStartElement("refreshContent"); cfg.Extensions.xml_marshal_list_cfg_battle_RefreshWave(refreshContent,ele); ele.WriteEndElement();
         
    }


}
}
}
