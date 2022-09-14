<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:xs="http://www.w3.org/2001/XMLSchema"
                xmlns:cs="http://nineml.com/ns/coffeesacks"
                exclude-result-prefixes="#all"
                version="3.0">

<xsl:param name="date-input" as="xs:string">1 September 2022</xsl:param>

<xsl:output indent="yes"/>

<xsl:template name="xsl:initial-template">
  <xsl:variable name="grammar" select="cs:grammar-uri('date.ixml')"/>
  <doc>
    <xsl:sequence select="cs:parse-string($grammar, $date-input)"/>
  </doc>
  <xsl:comment expand-text="yes">Run with {system-property('xsl:product-name')} {system-property('xsl:product-version')} {system-property('Q{http://saxon.sf.net/}platform')}</xsl:comment>
</xsl:template>

</xsl:stylesheet>