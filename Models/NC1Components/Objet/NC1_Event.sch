<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:event" prefix="nc1event" />
  <iso:pattern>
    <iso:title>NC1_Event validation rules</iso:title>
    <iso:rule context="/nc1event:NC1_Event/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.O')" diagnostics="D26821-en">NC1_Event.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement doit être dans la famille G*O************ .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26828-en">NC1_Event.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) = 0 else true()" diagnostics="D26822-en">NC1_Event.6: Lorsque l'événement est anticipé, la qualité de la mesure de localisation ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26826-en">NC1_Event.9: La localisation d'un événement ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Event.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1event:NC1_Event/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26827-en">NC1_Event.5: Le type de l'objet doit avoir pour valeur 30</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1event:NC1_Event/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26825-en">NC1_Event.7: Le responsable de la gestion de l'événement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1event:NC1_Event/tacticalData/initiatorEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26823-en">NC1_Event.8: L'acteur ayant provoqué l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1event:NC1_Event/tacticalData/involvedEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26824-en">NC1_Event.8: L'acteur impliqué dans l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26821-en">NC1_Event.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an event has to be in the family G*O ************ .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26822-en">NC1_Event.6: When the event is anticipated, the location measurement quality shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26823-en">NC1_Event.8: The actor having caused the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26824-en">NC1_Event.8: The actor involved in the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26825-en">NC1_Event.7: The responsible of the management of the event shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26826-en">NC1_Event.9: The location of the enemy event shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26827-en">NC1_Event.5: The type of the object has to have for value 30</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26828-en">NC1_Event.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>