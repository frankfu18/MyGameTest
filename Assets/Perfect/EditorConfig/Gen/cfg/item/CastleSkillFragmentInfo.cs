using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.item
{
[System.Serializable]
public  class CastleSkillFragmentInfo : ItemInfo
 {

    public int castleSkillId ;
     



    public const int TYPE_ID = 5055;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleSkillFragmentInfo(Perfect.Marshal.Octets os) : base(os)  {

        castleSkillId = os.ReadInt(); 
         
    }

    public CastleSkillFragmentInfo()
    {
    }

    public CastleSkillFragmentInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "castleSkillId":  castleSkillId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleSkillFragmentInfo");
        ele.WriteStartElement("castleSkillId"); ele.WriteInt(castleSkillId); ele.WriteEndElement();
         
    }


}
}
}
