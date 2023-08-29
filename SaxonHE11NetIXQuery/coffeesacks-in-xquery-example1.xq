declare namespace cs = "http://nineml.com/ns/coffeesacks";

declare namespace output = "http://www.w3.org/2010/xslt-xquery-serialization";

declare option output:method 'xml';
declare option output:indent 'yes';

declare variable $input-date as xs:string external := '29 August 2023';

<invisible-xml-test>
{
let $parser := cs:load-grammar('date.ixml')
return $parser($input-date)
}
</invisible-xml-test>