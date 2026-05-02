using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class KillEnergyAdd : EffectTarget
 {

    public float enAdd ;
     



    public const int TYPE_ID = 12207;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public KillEnergyAdd(Perfect.Marshal.Octets os) : base(os)  {

        enAdd = os.ReadFloat(); 
         
    }

    public KillEnergyAdd()
    {
    }

    public KillEnergyAdd(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "enAdd":  enAdd = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "KillEnergyAdd");
        ele.WriteStartElement("enAdd"); ele.WriteFloat(enAdd); ele.WriteEndElement();
         
    }


}
}
}
