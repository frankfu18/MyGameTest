using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.sysbuff
{
[System.Serializable]
public  class BattleStartBuff : SysBuffInfo
 {

    public int buffId ;
     



    public const int TYPE_ID = 2534;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleStartBuff(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         
    }

    public BattleStartBuff()
    {
    }

    public BattleStartBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BattleStartBuff");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         
    }


}
}
}
