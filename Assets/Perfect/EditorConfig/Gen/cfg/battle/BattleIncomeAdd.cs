using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class BattleIncomeAdd : BattleStartBuffContent
 {

    public float addRatio ;
     



    public const int TYPE_ID = 35767;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleIncomeAdd(Perfect.Marshal.Octets os) : base(os)  {

        addRatio = os.ReadFloat(); 
         
    }

    public BattleIncomeAdd()
    {
    }

    public BattleIncomeAdd(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "addRatio":  addRatio = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BattleIncomeAdd");
        ele.WriteStartElement("addRatio"); ele.WriteFloat(addRatio); ele.WriteEndElement();
         
    }


}
}
}
