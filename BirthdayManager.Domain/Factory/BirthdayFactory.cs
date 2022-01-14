using System;
using System.Collections.Generic;
using System.Linq;
using BirthdayManager.Data.Models;
using BirthdayManager.Domain.DTO;

namespace BirthdayManager.Domain.Factory
{
    public static class BirthdayFactory
    {
        public static Birthday ToBirthdayData(this BirthdayDTO.Create data)
        {
            var birthday = new Birthday();
            birthday.Name = data.Name;
            birthday.Date = data.Date.ToString("yyyy'-'MM'-'dd");

            return birthday;
        }

        public static BirthdayDTO.Get ToBirthdayDTO(this Birthday data)
        {
            var birthdayDto = new BirthdayDTO.Get();

            birthdayDto.Id = data.Id;
            birthdayDto.Name = data.Name;
            birthdayDto.Date = DateTime.Parse(data.Date);

            return birthdayDto;
        }

        public static List<BirthdayDTO.Get> ToDTOList(this IEnumerable<Birthday> listData) =>
            listData.Select(data => data.ToBirthdayDTO()).ToList();        
    }
}