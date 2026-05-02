using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SelectBuffType1 : SelectBuffType
 {




    public const int TYPE_ID = 62026;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SelectBuffType1(Perfect.Marshal.Octets os) : base(os)  {

    }

    public SelectBuffType1()
    {
    }

    public SelectBuffType1(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SelectBuffType1");
    }


}
}
}
