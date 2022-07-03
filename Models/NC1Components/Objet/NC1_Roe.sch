<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:roe" prefix="nc1roe" />
  <iso:pattern>
    <iso:title>NC1_Roe validation rules</iso:title>
    <iso:rule context="/nc1roe:NC1_Roe/@id">
      <iso:assert test="matches(.,'^52:')" diagnostics="D26835-en">NC1_Roe.2: Le type de l'objet doit avoir pour valeur 52</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26835-en">NC1_Roe.2: The type of the object has to have for value 52</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>