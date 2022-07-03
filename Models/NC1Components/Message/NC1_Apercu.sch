<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:apercu" prefix="nc1apercu" />
  <iso:pattern>
    <iso:title>NC1_Apercu validation rules</iso:title>
    <iso:rule context="/nc1apercu:NC1_Apercu">
      <iso:assert test="count(@referenceMessageId) = 1" diagnostics="D26426-en">NC1_Apercu.2: Dans l'en-tête, le message en référence doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1apercu:NC1_Apercu/willco">
      <iso:assert test="if (. = '0') then count(../cantco)=0 else true()" diagnostics="D26427-en">NC1_Apercu.3: Lorsque l'ordre est prêt à être exécuté, le paragraphe traitant des raisons d'un non aperçu immédiat ne doit pas être renseigné.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26426-en">NC1_Apercu.2: In the header, the referenced message shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26427-en">NC1_Apercu.3: When the order is ready to be executed, the paragraph dealing with the reasons for non-immediate overview should not be filled.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>