<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:groundtrack" prefix="nc1groundtrack" />
  <iso:pattern>
    <iso:title>NC1_GroundTrack validation rules</iso:title>
    <iso:rule context="/nc1groundtrack:NC1_GroundTrack/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.(G.E|F.G[^B])')" diagnostics="D26911-en">NC1_GroundTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Les familles autorisées par la règle sont : S*G*E*****--*** ou S*F*G*****--*** sauf S*F*GB****--***.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26917-en">NC1_GroundTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26912-en">NC1_GroundTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position et la qualité de la mesure de localisation sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26914-en">NC1_GroundTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundtrack:NC1_GroundTrack/@id">
      <iso:assert test="matches(.,'^12:')" diagnostics="D26916-en">NC1_GroundTrack.5: Le type de l'objet doit avoir pour valeur 12</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundtrack:NC1_GroundTrack/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26915-en">NC1_GroundTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1groundtrack:NC1_GroundTrack/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26913-en">NC1_GroundTrack.8: L'unité d'appartenance de la piste  doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26911-en">NC1_GroundTrack.3: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a ground track has to be in families S*G*E********** or S*F*G********** except S*F*GB*********.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26912-en">NC1_GroundTrack.6: When the track is anticipated, the timestamp of the statement of its position and the quality of the measure of location on the ground should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26913-en">NC1_GroundTrack.8: The unit the track belongs to shall shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26914-en">NC1_GroundTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26915-en">NC1_GroundTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26916-en">NC1_GroundTrack.5: The type of the object has to have for value 12</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26917-en">NC1_GroundTrack.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>