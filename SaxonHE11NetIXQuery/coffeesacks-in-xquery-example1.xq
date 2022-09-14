declare namespace cs = "http://nineml.com/ns/coffeesacks";

declare namespace output = "http://www.w3.org/2010/xslt-xquery-serialization";

declare option output:method 'xml';
declare option output:indent 'yes';

declare variable $input-date as xs:string external := '1 September 2022';

<invisible-xml-test>
{
let $grammar := cs:grammar-uri('date.ixml')
return cs:parse-string($grammar, $input-date)
}
</invisible-xml-test>