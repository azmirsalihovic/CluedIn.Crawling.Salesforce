using System;
using System.Collections.Generic;
using System.Text;

namespace Semler.Common.Vocabularies
{
    public static class SemlerVocabularies
    {
        public static AccountVocabulary Account => new AccountVocabulary();
        public static PrivateCustomerVocabulary PrivateCustomer => new PrivateCustomerVocabulary();
        public static BusinessCustomerVocabulary BusinessCustomer => new BusinessCustomerVocabulary();
        public static ContactVocabulary Contact => new ContactVocabulary();
        public static SemlerAddress SemlerAddress => new SemlerAddress();
    }
}
