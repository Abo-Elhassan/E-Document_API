using AutoMapper;
using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.AutoMapper_Service.Converter
{
    public class StringToTravelDeskRequisitionListConverter : ITypeConverter<string, List<TravelDeskRequisition>>
    {
        public List<TravelDeskRequisition> Convert(string source, List<TravelDeskRequisition> destination, ResolutionContext context)
        {
            return source.Split(',')
                         .Select(item => Enum.Parse<TravelDeskRequisition>(item))
                         .ToList();
        }
    }
}
