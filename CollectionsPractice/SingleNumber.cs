using System;

namespace CollectionsPractice
{
    internal class SingleNumber
    {
        private readonly Dictionary<int, int> _numberAndTimesPairs = [];
        private readonly List<int> _result = [];

        public int[] GetSingleNumbersOf(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (_numberAndTimesPairs.ContainsKey(number))
                {
                    _numberAndTimesPairs[number] = _numberAndTimesPairs.GetValueOrDefault(number) + 1;
                }
                else
                {
                    _numberAndTimesPairs.Add(number, 1);
                }
            }

            foreach(var key in _numberAndTimesPairs)
            {
                if(key.Value == 1)
                {
                    _result.Add(key.Key);
                }
            }

            return _result.ToArray();
        }
    }
}
