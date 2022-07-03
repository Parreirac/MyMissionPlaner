<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:route" prefix="nc1route" />
  <iso:pattern>
    <iso:title>NC1_Route validation rules</iso:title>
    <iso:rule context="/nc1route:NC1_Route/location/endPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26856-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26862-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point d'arrivée doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point d'arrivée doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1route:NC1_Route/location/startPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26855-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26861-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point de départ doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point de départ doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1route:NC1_Route/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26860-en">NC1_Route.5: Le type de l'objet doit avoir pour valeur 38</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1route:NC1_Route/location/endTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26858-en">NC1_Route.6: L'identifiant du point d'arrivée de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1route:NC1_Route/location/startTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26857-en">NC1_Route.6: L'identifiant du point de départ de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1route:NC1_Route/location/segment/groundEntityId/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26859-en">NC1_Route.7: L'entité terrain représentant un tronçon d'itinéraire doit être une entité terrain (NC1_GroundEntity).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26855-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26856-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26857-en">NC1_Route.6: The route start point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26858-en">NC1_Route.6: The route end point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26859-en">NC1_Route.7: The ground entity associated to a route section shall be a NC1_GroundEntity object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26860-en">NC1_Route.5: The type of the object has to have for value 38</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26861-en">NC1_Route.4: The 13th and 14th characters of the Code of the starting point symbol must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26862-en">NC1_Route.4: The 13th and 14th characters of the Code of the symbol of the end point must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>