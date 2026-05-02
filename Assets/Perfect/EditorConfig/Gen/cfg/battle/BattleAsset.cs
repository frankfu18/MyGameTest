using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class BattleAsset :   cfg.EditorWriter 
 {

    public int assetId ;
     public cfg.battle.EBattleAssetType assetType ;
     public string path  = "";
     public bool loop ;
     public float endDestory ;
     public cfg.battle.EBattleAssetBindPointType bindPoint ;
     



    public const int TYPE_ID = 25306;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleAsset(Perfect.Marshal.Octets os) {

        assetId = os.ReadInt(); 
         assetType = (cfg.battle.EBattleAssetType)(os.ReadInt()); 
         path = os.ReadString(); 
         loop = os.ReadBool(); 
         endDestory = os.ReadFloat(); 
         bindPoint = (cfg.battle.EBattleAssetBindPointType)(os.ReadInt()); 
         
    }

    public BattleAsset()
    {
    }

    public BattleAsset(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "assetId":  assetId = ele.ReadInt(); break; 
             case "assetType":  assetType = ele.ReadEnum<cfg.battle.EBattleAssetType>(); break; 
             case "path":  path = ele.ReadString2(); break; 
             case "loop":  loop = ele.ReadBool(); break; 
             case "endDestory":  endDestory = ele.ReadFloat(); break; 
             case "bindPoint":  bindPoint = ele.ReadEnum<cfg.battle.EBattleAssetBindPointType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BattleAsset");
        ele.WriteStartElement("assetId"); ele.WriteInt(assetId); ele.WriteEndElement();
         ele.WriteStartElement("assetType"); ele.WriteEnum(assetType); ele.WriteEndElement();
         ele.WriteStartElement("path"); ele.WriteString2(path); ele.WriteEndElement();
         ele.WriteStartElement("loop"); ele.WriteBool(loop); ele.WriteEndElement();
         ele.WriteStartElement("endDestory"); ele.WriteFloat(endDestory); ele.WriteEndElement();
         ele.WriteStartElement("bindPoint"); ele.WriteEnum(bindPoint); ele.WriteEndElement();
         
    }


}
}
}
