<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:iffprocedure" prefix="nc1iffprocedure" />
  <iso:pattern>
    <iso:title>NC1_IffProcedure validation rules</iso:title>
    <iso:rule context="/nc1iffprocedure:NC1_IffProcedure/@id">
      <iso:assert test="matches(.,'^35:')" diagnostics="D26834-en">NC1_IffProcedure.1: Le type de l'objet doit avoir pour valeur 35</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1iffprocedure:NC1_IffProcedure/tacticalData/*/period">
      <iso:assert test="count(duration) &gt; 0" diagnostics="D26833-en">NC1_IffProcedure.2: La durée de la période des codes ou des modes IFF doit être renseignée.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26833-en">NC1_IffProcedure.2: The duration of the period of the codes or the modes IFF must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26834-en">NC1_IffProcedure.1: The type of the object has to have for value 35</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>