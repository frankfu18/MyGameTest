using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class EffectNum : BulletDestroyType
 {

    public int effectNum ;
     



    public const int TYPE_ID = 24046;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EffectNum(Perfect.Marshal.Octets os) : base(os)  {

        effectNum = os.ReadInt(); 
         
    }

    public EffectNum()
    {
    }

    public EffectNum(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "effectNum":  effectNum = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "EffectNum");
        ele.WriteStartElement("effectNum"); ele.WriteInt(effectNum); ele.WriteEndElement();
         
    }


}
}
}
