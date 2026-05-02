using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SelectBuffType2 : SelectBuffType
 {




    public const int TYPE_ID = 62027;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SelectBuffType2(Perfect.Marshal.Octets os) : base(os)  {

    }

    public SelectBuffType2()
    {
    }

    public SelectBuffType2(XmlElement e)
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
        ele.WriteAttributeString("type", "SelectBuffType2");
    }


}
}
}
