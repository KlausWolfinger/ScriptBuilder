<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html xmlns="http://www.w3.org/1999/xhtml">
  <head>
  	<title>List of Configuration Parameters</title>
  	<link href="doxygen.css" rel="stylesheet" type="text/css" />
  </head>
  <body>
  <h2>List of Configuration Parameters</h2>
  <table class="doxtable">
    <tr>
      <th>Name</th>
      <th>Type</th>
      <th>Description</th>
      <th>Default Value</th>
      <th>Range</th>
      <th>Length</th>
      <th>Unit</th>
      <th>Process Restart Required</th>
      <th>Access</th>
      <th>Displayed in Custom GUI</th>
    </tr>
    <xsl:for-each select="RtpParameterList/RtpParameter">
    <tr>
      <td><xsl:value-of select="Name"/></td>
      <td><xsl:value-of select="Type"/></td>
      <td><xsl:value-of select="Description"/></td>
      <td><xsl:value-of select="Default"/></td>
      <td><xsl:value-of select="Range"/></td>
      <td><xsl:value-of select="Length"/></td>
      <td><xsl:value-of select="Unit"/></td>
      <td><xsl:value-of select="Restart"/></td>
      <td><xsl:value-of select="Access"/></td>
      <td><xsl:value-of select="CustomGUI"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet> 