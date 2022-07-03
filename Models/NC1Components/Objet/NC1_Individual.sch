<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:individual" prefix="nc1individual" />
  <iso:pattern>
    <iso:title>NC1_Individual validation rules</iso:title>
    <iso:rule context="/nc1individual:NC1_Individual/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.MG(AUA|PI)')" diagnostics="D26774-en">NC1_Individual.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un individu doit être dans les familles G*C*MGAUA****** ou G*C*MGPI--***** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26782-en">NC1_Individual.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26775-en">NC1_Individual.6: Lorsque l'individu est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26780-en">NC1_Individual.11: La localisation d'un individu ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Individual.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1individual:NC1_Individual/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26781-en">NC1_Individual.5: Le type de l'objet doit avoir pour valeur 3</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1individual:NC1_Individual/tacticalData">
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(specialIndicator) = 0 else true()" diagnostics="D26776-en">NC1_Individual.7: Lorsque l'individu est ami (FRIEND ou ASSUMED FRIEND), l'indicateur d'intérêt spécifique ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1individual:NC1_Individual/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26777-en">NC1_Individual.8: Le responsable de l'individu ou du groupe d'individus doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1individual:NC1_Individual/historyItems/historyItem/eventId/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26778-en">NC1_Individual.9: L'objet NC1 relié au fait de main courante doit être un événement (NC1_Event).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1individual:NC1_Individual/administrativeProperties/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26779-en">NC1_Individual.10: L'unité d'appartenance de l'individu doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26774-en">NC1_Individual.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an individual has to be in families G*C*MGAUA ****** or G*C*MGPI - ***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26775-en">NC1_Individual.6: When the individual is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26776-en">NC1_Individual.7: For a friendly individual (FRIEND or ASSUMED FRIEND), the SPI indicator shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26777-en">NC1_Individual.8: The responsible of the facility shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26778-en">NC1_Individual.9: The NC1 object linked to the facts register shall be an event (NC1_Event).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26779-en">NC1_Individual.10: The unit the individual belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26780-en">NC1_Individual.11: The location of the enemy individual shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26781-en">NC1_Individual.5: The type of the object has to have for value 3</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26782-en">NC1_Individual.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>