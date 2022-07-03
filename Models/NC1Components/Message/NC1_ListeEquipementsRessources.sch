<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:ler" prefix="nc1ler" />
  <iso:pattern>
    <iso:title>NC1_ListeEquipementsRessources validation rules</iso:title>
    <iso:rule context="/nc1ler:NC1_ListeEquipementsRessources/@situation">
      <iso:assert test=". = 'DQP'" diagnostics="D26762-en">NC1_ListeEquipementsRessources.1: la situation peut uniquement valoir « DQP » [COHER. MSG-CTXTE]</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26762-en">NC1_ListeEquipementsRessources.1: "The context shall only be ""DQP"" [COHER. MSG-CTXTE]"</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>