<?xml version="1.0" encoding="UTF-8" ?>
<xsl:transform xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="2.0">
    <xsl:output method="xml" doctype-public="XSLT-compat" omit-xml-declaration="yes" encoding="UTF-8" indent="yes" />

    <xsl:template match="Table">
        <Result>
            <DocumentInfo>
                <xsl:attribute name="NumberOfItems">
                    <xsl:value-of select="count(//Item)"/>
                </xsl:attribute>
                <xsl:copy-of select="Total"/>
                <RealTotal>
                    <xsl:value-of select="$RealTotal"/>
                </RealTotal>
                <IsEqual>
                    <xsl:value-of select="boolean(//Total[. = $RealTotal])"/>
                </IsEqual>
                <DifferentTypes>
                    <xsl:apply-templates select="Item"/>
                </DifferentTypes>
            </DocumentInfo>
        </Result>
    </xsl:template>

    <xsl:template match="Table/Item">
        <Type>
            <xsl:value-of select="Type"/>
        </Type>
    </xsl:template>

    <xsl:variable name="RealTotal">
        <xsl:value-of select="sum(//Item/Subtotal)"/>
    </xsl:variable>

</xsl:transform>
