<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
          <Order>
            <OrderId>20181111001</OrderId>
            <CilentName>aaa</CilentName>
            <CilentTelephoneNumber>10086</CilentTelephoneNumber>
            <orderDetails>
              <goodName>A</goodName>
              <goodNumber>5</goodNumber>
              <goodPrice>20</goodPrice>
          </orderDetails>
          </Order>
          <Order>
            <OrderId>20181111002</OrderId>
            <CilentName>aab</CilentName>
            <CilentTelephoneNumber>10085</CilentTelephoneNumber>
            <orderDetails>
              <goodName>B</goodName>
              <goodNumber>5</goodNumber>
              <goodPrice>7</goodPrice>
            </orderDetails>
          </Order>
          
      
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>
