using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class KillExpAdd : EffectTarget
 {

    public float expAdd ;
     



    public const int TYPE_ID = 54777;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public KillExpAdd(Perfect.Marshal.Octets os) : base(os)  {

        expAdd = os.ReadFloat(); 
         
    }

    public KillExpAdd()
    {
    }

    public KillExpAdd(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "expAdd":  expAdd = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "KillExpAdd");
        ele.WriteStartElement("expAdd"); ele.WriteFloat(expAdd); ele.WriteEndElement();
         
    }


}
}
}
