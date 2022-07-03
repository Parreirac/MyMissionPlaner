<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:suppressionitsats" prefix="nc1suppritsats" />
  <iso:pattern>
    <iso:title>NC1_SuppressionItsAts validation rules</iso:title>
    <iso:rule context="/nc1suppritsats:NC1_SuppressionItsAts/deletedITSorATS/deletedITSorATSId/@id">
      <iso:assert test="matches(.,'^34:')" diagnostics="D26532-en">NC1_SuppressionItsAts.2: L'itinéraire ou l'aire de sauvegarde supprimée doit être une zone aérienne (NC1_AcmWez).</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26532-en">NC1_SuppressionItsAts.2: The deleted ITS or ATS must be an air zone (NC1_AcmWez).</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>