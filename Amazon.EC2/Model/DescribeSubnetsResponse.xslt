<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2012-04-01/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2012-04-01/'" />
	<xsl:template match="ec2:DescribeSubnetsResponse">
		<xsl:element name="DescribeSubnetsResponse" namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeSubnetsResult" namespace="{$ns}">
				<xsl:apply-templates select="ec2:subnetSet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:subnetSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Subnet" namespace="{$ns}">
				<xsl:element name="SubnetId" namespace="{$ns}">
					<xsl:value-of select="ec2:subnetId" />
				</xsl:element>
				<xsl:element name="SubnetState" namespace="{$ns}">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
				<xsl:element name="VpcId" namespace="{$ns}">
					<xsl:value-of select="ec2:vpcId" />
				</xsl:element>
				<xsl:element name="CidrBlock" namespace="{$ns}">
					<xsl:value-of select="ec2:cidrBlock" />
				</xsl:element>
				<xsl:element name="AvailableIpAddressCount" namespace="{$ns}">
					<xsl:value-of select="ec2:availableIpAddressCount" />
				</xsl:element>
				<xsl:element name="AvailabilityZone" namespace="{$ns}">
					<xsl:value-of select="ec2:availabilityZone" />
				</xsl:element>
        <xsl:apply-templates select="ec2:tagSet" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag" namespace="{$ns}">
        <xsl:element name="Key" namespace="{$ns}">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value" namespace="{$ns}">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
