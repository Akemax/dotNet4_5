using System.Collections;
using System.Collections.Generic;
using Web.Domain;

namespace Web.Dao
{
    public class QuestionDao
    {
        public IEnumerable<Question> getAll 
        { 
            get
            {
                return new List<Question>()
                {
                    new Question("ASP.NET - це ...", new List<Answear>()
                    {
                        new Answear("мова програмування, яка була написана на основі C++", false),
                        new Answear("дочірня компанія компанії Майкрософт", false),
                        new Answear("технологія створення вебзастосунків і вебсервісів від компанії Майкрософт", true),
                        new Answear("сайт в Інтернеті", false),
                    }),
                     new Question("IIS - це ...", new List<Answear>()
                    {
                        new Answear("бібліотека послуг Інтернету", false),
                        new Answear("послуги для надання інтернет-служб ASP.NET веб-застосункам", true),
                        new Answear("відлагуджувальник коду веб-додатку",false),
                        new Answear("система інформаційних інтернет ресурсів",false),
                    }),
                     new Question("Який батьківський клас усього контролю веб-сервера?", new List<Answear>()
                    {
                        new Answear("System.Web.UI.UserControl", false),
                        new Answear("System.Web.UI.Control", true),
                        new Answear("System.Web.UI.DataSourceControl", false),
                        new Answear("System.Web.UI.BasePartialCachingControl", false),
                    }),
                     new Question("Які з перелічених варіантів є вбудованим об'єктом в ASP.NET?", new List<Answear>()
                    {
                        new Answear("Сеанс", true),
                        new Answear("Клас", false),
                        new Answear("Питання", false),
                        new Answear("Немає правильної відповіді", false),
                    }),
					new Question("Який протокол використовується для виклику веб-служби?", new List<Answear>()
                    {
                        new Answear("IP-протокол", false),
                        new Answear("HTTP-протокол", true),
                        new Answear("FTP-протокол", false),
                        new Answear("TCP-протокол", false),
                    }),
					new Question("Яке розширення файлу веб-сервісу?", new List<Answear>()
                    {
                        new Answear(".web", false),
                        new Answear(".srv", false),
                        new Answear(".asmx", true),
                        new Answear(".webx", false),
                    }),
					new Question("Що таке MVC?", new List<Answear>()
                    {
                        new Answear("архітектурний стиль, за яким єдиний застосунок будується як сукупність невеличких сервісів, кожен з яких працює у своєму власному процесі та спілкується з рештою, використовуючи прості та швидкі протоколи передачі даних", false),
                        new Answear("архітектурний шаблон, який використовується під час проєктування та розробки програмного забезпечення", true),
                        new Answear("засіб зручної взаємодії користувача з інформаційною системою", false),
                        new Answear("модульний підхід до розробки програмного забезпечення, заснований на використанні розподілених, слабко пов'язаних замінних компонентів, оснащених стандартизованими інтерфейсами для взаємодії за стандартизованими протоколами", false),
                    }),
					new Question("Що таке ViewState?", new List<Answear>()
                    {
                        new Answear("функція ASP.NET зберігати значення сторінки перед її надсиланням на сервер", true),
                        new Answear("оглядова зона в веб-додатку", false),
                        new Answear("процес ідентифікації користувача", false),
                        new Answear("запит, який відправляється від клієнта на сервер з тієї ж сторінки, з якою працює користувач", false),
                    }),
					new Question("Основні вимоги до кешування такі:", new List<Answear>()
                    {
                        new Answear("Кешована веб-форма заморожує вміст на стороні сервера", true),
                        new Answear("Клас налагодження використовується для налагодження збірок", false),
                        new Answear("При встановленні true, властивість наказує клієнтському додатку не зберігати Cookie на жорсткому диску користувача в кінці сеансу.",false),
                        new Answear("Дані не захищені", false),
                    }),
					new Question("Які переваги ASP.NET?", new List<Answear>()
                    {
                        new Answear("Зворотній зв'язок", false),
                        new Answear("Дані проставляються на URL-адресу.", false),
                        new Answear("Кешування об'єктів і сторінок", true),
                        new Answear("Легкі вимоги до кодування", false),
                    })
					
                };
            }
        } 
    }
}
