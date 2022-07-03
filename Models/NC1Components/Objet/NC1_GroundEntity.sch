<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:groundentity" prefix="nc1groundentity" />
  <iso:pattern>
    <iso:title>NC1_GroundEntity validation rules</iso:title>
    <iso:rule context="/nc1groundentity:NC1_GroundEntity/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26789-en">NC1_GroundEntity.2: Le type de l'objet doit avoir pour valeur 20</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26789-en">NC1_GroundEntity.2: The type of the object has to have for value 20</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>