using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class MoneyWaveAdd : EffectTarget
 {

    public int moneyAdd ;
     



    public const int TYPE_ID = 26679;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MoneyWaveAdd(Perfect.Marshal.Octets os) : base(os)  {

        moneyAdd = os.ReadInt(); 
         
    }

    public MoneyWaveAdd()
    {
    }

    public MoneyWaveAdd(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "moneyAdd":  moneyAdd = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MoneyWaveAdd");
        ele.WriteStartElement("moneyAdd"); ele.WriteInt(moneyAdd); ele.WriteEndElement();
         
    }


}
}
}
