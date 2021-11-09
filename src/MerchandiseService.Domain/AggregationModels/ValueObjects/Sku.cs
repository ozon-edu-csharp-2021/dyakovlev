using System.Collections.Generic;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.ValueObjects
{
    public class Sku : ValueObject
    {
        private int _sku;

        public Sku(int sku)
        {
            _sku = sku;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _sku;
        }

        public static implicit operator Sku(int value) => new(value);
        public static implicit operator int(Sku sku) => sku._sku;
    }
}