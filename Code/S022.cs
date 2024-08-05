using System;
class TelNo {
    string countryCode, areaCode, localNumber;
}
class Name {
    string first, last;
}
class Person {
    Name english, chinese;
    TelNo telephone, fax, mobile;
}
class Organization {
    string id;
    string englishName, chineseName;
    TelNo mainLineNumber, faxNo;
    Person contact;
    //...
}
