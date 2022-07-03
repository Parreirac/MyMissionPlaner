<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:apercu3d" prefix="nc1apercu3d" />
  <iso:pattern>
    <iso:title>NC1_Apercu3D validation rules</iso:title>
    <iso:rule context="/nc1apercu3d:NC1_Apercu3D">
      <iso:assert test="count(@referenceMessageId) = 1" diagnostics="D26537-en">NC1_Apercu3D.2: Dans l'en-tête, le message en référence doit être renseigné.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26537-en">NC1_Apercu3D.2: In the header, the referenced message shall be provided.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>