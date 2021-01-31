using Microsoft.AspNetCore.Mvc.ModelBinding;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAng.Models.SupportingModels
{
    public class ContactModelBinder : IModelBinder
    {
        public  Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // в случае ошибки возвращаем исключение
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            // с помощью поставщика значений получаем данные из запроса
            var datePartValues = bindingContext.ValueProvider.GetValue("Date");
            var timePartValues = bindingContext.ValueProvider.GetValue("Time");
            var namePartValues = bindingContext.ValueProvider.GetValue("Name");
            var idPartValues = bindingContext.ValueProvider.GetValue("Id");

            //string jsonString;
            //using (StreamReader reader = new StreamReader(bindingContext.ActionContext.HttpContext.Request.Body, Encoding.UTF8))
            //{
            //    jsonString = await reader.ReadToEndAsync();
            //}

            //JObject o = JObject.Parse(jsonString);



            var p = bindingContext.ValueProvider.GetValue("params/");

            var idv = bindingContext.ValueProvider.GetValue("id");
            var photov = bindingContext.ValueProvider.GetValue("photo");
            var dateOfBirthv = bindingContext.ValueProvider.GetValue("dateOfBirth");
            var positionv = bindingContext.ValueProvider.GetValue("position");
            var phonesv = bindingContext.ValueProvider.GetValue("phones");
            var emailsv = bindingContext.ValueProvider.GetValue("emails");
            var sitesv = bindingContext.ValueProvider.GetValue("sites");
            var messangerUrlsv = bindingContext.ValueProvider.GetValue("messangerUrls");
            var addressesv = bindingContext.ValueProvider.GetValue("addresses");
            var contactTypev = bindingContext.ValueProvider.GetValue("contactType");
            var contactSourcev = bindingContext.ValueProvider.GetValue("contactSource");
            var descriptionv = bindingContext.ValueProvider.GetValue("description");
            var permissionsv = bindingContext.ValueProvider.GetValue("permissions");
            var namev = bindingContext.ValueProvider.GetValue("name");








            // получаем значения
            string date = datePartValues.FirstValue;
            string time = timePartValues.FirstValue;
            string name = namePartValues.FirstValue;
            string id = idPartValues.FirstValue;

            // если id не установлен, например, при создании модели, генерируем его
            if (String.IsNullOrEmpty(id)) id = Guid.NewGuid().ToString();

            // если name не установлено
            if (String.IsNullOrEmpty(name)) name = "Неизвестное событие";

            // Парсим дату и время
            DateTime.TryParse(date, out var parsedDateValue);
            DateTime.TryParse(time, out var parsedTimeValue);

            // Объединяем полученные значения в один объект DateTime
            DateTime fullDateTime = new DateTime(parsedDateValue.Year,
                            parsedDateValue.Month,
                            parsedDateValue.Day,
                            parsedTimeValue.Hour,
                            parsedTimeValue.Minute,
                            parsedTimeValue.Second);


            int intId = 0;
            Int32.TryParse("id", out intId);
            // устанавливаем результат привязки
            bindingContext.Result = ModelBindingResult.Success(new Contact { Id = intId,  Name = new UserName() { FirstName = name } });
            return Task.CompletedTask;
        }
        public async Task<string> ReadRequestBodyAsync(Stream body)
        {
            using (StreamReader reader = new StreamReader(body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}