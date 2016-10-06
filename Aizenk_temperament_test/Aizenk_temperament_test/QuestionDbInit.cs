using Aizenk_temperament_test.Models;
using Aizenk_temperament_test.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aizenk_temperament_test
{
    public class QuestionDbInit : DropCreateDatabaseAlways<TestDbContext>
    {
        protected override void Seed(TestDbContext context)
        {
            IList<Question> defaultQuestions = new List<Question>();

            defaultQuestions.Add(new Question() { Id = 1, Text = "Часто ли Вы испытываете тягу к новым впечатлениям, к тому, чтобы встряхнуться, испытать возбуждение?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 2, Text = "Часто ли Вы нуждаетесь в друзьях, которые могут Вас ободрить или утешить?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 3, Text = "Вы считаете себя человеком беззаботным?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 4, Text = "Трудно ли Вам отказаться от своих намерений?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 5, Text = "Обдумываете ли Вы свои дела не спеша, предпочитаете подождать, прежде чем действовать?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 6, Text = "Всегда ли Вы сдерживаете свои обещания?", Category = "ATrue" });
            defaultQuestions.Add(new Question() { Id = 7, Text = "Часто ли у Вас бывают спады и подъемы настроения?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 8, Text = "Обычно Вы поступаете и говорите быстро, не раздумывая?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 9, Text = "Возникало ли у Вас когда-нибудь чувство, что Вы несчастливы, хотя никакой серьезной причины для этогоне было ? ", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 10, Text = "Верно ли, что на спор Вы готовы решиться на очень многое?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 11, Text = "Смущаетесь ли Вы, когда хотите познакомиться с человеком противоположного пола?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 12, Text = "Бывает ли когда-нибудь, что, разозлившись, Вы выходите из себя?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 13, Text = "Часто ли Вы действуете под влиянием минутного настроения?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 14, Text = "Часто ли Вы беспокоитесь из-за того, что сделали или сказали что-нибудь такое, чего не следовало бы делатьили говорить ? ", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 15, Text = "Предпочитаете ли Вы обычно книги встречам с людьми?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 16, Text = "Легко ли Вас обидеть?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 17, Text = "Любите ли Вы часто бывать в компании?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 18, Text = "Бывают ли у Вас иногда мысли, которые Вы хотели бы скрыть от других?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 19, Text = "Верно ли, что Вы иногда полны энергии так, что все горит в руках, а иногда совсем вялы?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 20, Text = "Предпочитаете ли Вы иметь поменьше друзей, но зато близких Вам?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 21, Text = "Часто ли Вы мечтаете?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 22, Text = "Когда на Вас кричат, Вы отвечаете тем же?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 23, Text = "Часто ли Вас беспокоит чувство вины?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 24, Text = "Все ли Ваши привычки хороши и желательны?", Category = "ATrue" });
            defaultQuestions.Add(new Question() { Id = 25, Text = "Способны ли Вы дать волю своим чувствам и вовсю повеселиться в компании?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 26, Text = "Можете ли Вы сказать, что у Вас часто нервы бывают натянуты до предела?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 27, Text = "Считают ли Вас человеком живым и веселым?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 28, Text = "Часто ли, сделав какое-нибудь важное дело, Вы испытываете чувство, что могли бы сделать его лучше?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 29, Text = "Вы больше молчите, когда находитесь в обществе других людей?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 30, Text = "Вы иногда сплетничаете?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 31, Text = "Бывает ли, что Вам не спится из-за того, что разные мысли лезут в голову?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 32, Text = "Если Вы хотите узнать о чем-нибудь, то предпочитаете прочесть об этом в книге, нежели спросить у людей ? ", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 33, Text = "Бываете ли Вы иногда так возбуждены, что не можете усидеть на месте?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 34, Text = "Нравится ли Вам работа, которая требует от Вас постоянного внимания?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 35, Text = "Бывают ли у Вас слабость и головокружения?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 36, Text = "Всегда ли Вы платили бы за провоз багажа на транспорте, если бы не опасались проверки?", Category = "ATrue" });
            defaultQuestions.Add(new Question() { Id = 37, Text = "Вам неприятно находиться в обществе, где подшучивают друг над другом?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 38, Text = "Раздражительны ли Вы?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 39, Text = "Нравится ли Вам работа, которая требует быстроты действий?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 40, Text = "Верно ли, что нередко Вам не дают покоя мысли о разных неприятностях и ужасах, которые могли бы произойти, хотя все кончилось благополучно ? ", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 41, Text = "Вы неторопливы в движениях?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 42, Text = "Вы когда-нибудь опаздывали на свидание или в школу (на работу)?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 43, Text = "Часто ли Вам снятся кошмары?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 44, Text = "Верно ли, что Вы так любите поговорить, что никогда не упустите случая побеседовать с незнакомым человеком ? ", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 45, Text = "Бывают ли у Вас сильные головные боли?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 46, Text = "Вы бы чувствовали себя несчастным, если бы длительное время были лишены общения с людьми?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 47, Text = "Можете ли Вы назвать себя нервным человеком?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 48, Text = "Есть ли среди Ваших знакомых люди, которые Вам явно не нравятся?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 49, Text = "Можете ли Вы сказать, что Вы весьма уверенный в себе человек?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 50, Text = "Легко ли Вы обижаетесь, когда люди указывают на Ваши ошибки в работе или на Ваши личные промахи?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 51, Text = "Вы считаете, что трудно получить настоящее удовольствие от вечеринки?", Category = "BFalse" });
            defaultQuestions.Add(new Question() { Id = 52, Text = "Беспокоит ли Вас чувство, что Вы чем-то хуже других?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 53, Text = "Легко ли Вам внести оживление в довольно скучную компанию?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 54, Text = "Бывает ли, что Вы говорите о вещах, в которых не разбираетесь?", Category = "AFalse" });
            defaultQuestions.Add(new Question() { Id = 55, Text = "Беспокоитесь ли Вы о своем здоровье?", Category = "C" });
            defaultQuestions.Add(new Question() { Id = 56, Text = "Любите ли Вы подшучивать над другими?", Category = "BTrue" });
            defaultQuestions.Add(new Question() { Id = 57, Text = "Страдаете ли Вы от длительной бессонницы?", Category = "C" });

            foreach (Question q in defaultQuestions)
            {
                context.Questions.Add(q);
            }

            base.Seed(context);
        }
    }
}