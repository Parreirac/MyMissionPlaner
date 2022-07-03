<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:groundparticipant" prefix="nc1groundparticipant" />
  <iso:pattern>
    <iso:title>NC1_GroundParticipant validation rules</iso:title>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]G.E')" diagnostics="D26745-en">NC1_GroundParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant terrestre doit être dans les familles S*G*E*****--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26750-en">NC1_GroundParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime)+count(quality) = 0 else true()" diagnostics="D26746-en">NC1_GroundParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/@id">
      <iso:assert test="matches(.,'^9:')" diagnostics="D26749-en">NC1_GroundParticipant.6: Le type de l'objet doit avoir pour valeur 9</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26747-en">NC1_GroundParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26748-en">NC1_GroundParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence='true' or presence=1) then idParticipant else true()" diagnostics="D26751-en">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundparticipant:NC1_GroundParticipant/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^9:')">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit représenter un participant terrestre (la donnée id doit commencer par 9:).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26745-en">NC1_GroundParticipant.2: The symbology standard to be used shall be APP-6(B). The symbol code of an obstacle shall be of the following type:  S*G*E*****--*** or S*F*******--*** . Participant identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26746-en">NC1_GroundParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26747-en">NC1_GroundParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26748-en">NC1_GroundParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26749-en">NC1_GroundParticipant.6: The type of the object has to have for value 9</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26750-en">NC1_GroundParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26751-en">NC1_GroundParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>