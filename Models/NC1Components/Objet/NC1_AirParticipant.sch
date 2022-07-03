<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:airparticipant" prefix="nc1airparticipant" />
  <iso:pattern>
    <iso:title>NC1_AirParticipant validation rules</iso:title>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]A.......--...')" diagnostics="D26925-en">NC1_AirParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant aérien doit être dans les familles S*A*******--*** et l'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26930-en">NC1_AirParticipant.5: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26926-en">NC1_AirParticipant.4: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/@id">
      <iso:assert test="matches(.,'^11:')" diagnostics="D26929-en">NC1_AirParticipant.6: Le type de l'objet doit avoir pour valeur 11</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26927-en">NC1_AirParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26928-en">NC1_AirParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence=true()) then idParticipant else true()" diagnostics="D26931-en">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1airparticipant:NC1_AirParticipant/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^11:')">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit représenter un participant aérien (la donnée id doit commencer par 11:).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26925-en">NC1_AirParticipant.2: "The used standard of symbology has to be the APP-6 (B). The code symbol of an air participant has to be in families S*A ******* - *** and the identity of a participant owes ""being ASSUMED FRIEND"", or ""FRIEND"" (In or F in the APP6B)".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26926-en">NC1_AirParticipant.4: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26927-en">NC1_AirParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26928-en">NC1_AirParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26929-en">NC1_AirParticipant.6: The type of the object has to have for value 11</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26930-en">NC1_AirParticipant.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26931-en">NC1_AirParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>