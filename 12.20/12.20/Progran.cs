using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._20
{
    class Progran
    {
        static  void Main()
        {
            Person[] PeopleArray = new Person[6]
            {
                new Person ("100多年前,电的出现转变了无数的产业。","人工智能也将产生同样100年前的电力系统真的很复杂。"),
                new Person ("你需要在直流电、交流电、不同的电压、不同水平的可靠性以及价近年来，","在IT和互联网的变革中，我们看到了CIO的崛起,来帮助公司组织信息。"),
                new Person ("随着IT成熟人工智能仍不成熟，但发展迅速。所以期望每个高管完全了解人工智能是不合乎情理的。","但如果你所拥有首席人工智能官的收益是他能够确保全公司简仓( silos )都应用人工智能。"),
                new Person("大部分公司天然的专业的人工智能团队要比单个礼物卡部门有更高的机会吸引到人工智能人才和维护标准，","而且无论怎对人工智能和数据基础设施好的技术理解。例如,他们曾建立过重要的机器学习系统。"),
                new Person("在人工智能时跨职能的工作能力。人工智能本身不是产品或业务,而是-种用来帮助已有业务线并创造全新产品和强大的企业家技能。","人工智能创造建立新产品的机会,从自动驾驶汽车到能与之交流的代理,这在几吸引并留住人工智能人才的能力。"),
                new Person("这种人才备受追捧。在新的大学毕业生中，","我观察到该领域内的学有效的首席人工智能官应该有管理人工智能团队的经验。由于人工智能进化飞快，他们需要跟得上变")
            };
            people
        }
    }
    public class Person
    {
        public Person(string fName,string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
        public string FirstName;
        public string LastName;
    }
}
