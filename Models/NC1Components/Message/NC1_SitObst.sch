<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:sitobst" prefix="nc1sitobst" />
  <iso:pattern>
    <iso:title>NC1_SitObst validation rules</iso:title>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($ObstacleFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26759-en">NC1_Obstacle.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Obstacle.10: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26754-en">NC1_Obstacle.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26755-en">NC1_Obstacle.5: Lorsque l'obstacle est anticipé, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26760-en">NC1_Obstacle.9: La localisation d'un obstacle ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Obstacle.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/@id">
      <iso:assert test="matches(.,'^17:')" diagnostics="D26761-en">NC1_Obstacle.4: Le type de l'objet doit avoir pour valeur 17</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/tacticalData/number9">
      <iso:assert test="if (matches(../symbolCode, ':.F')) then matches(., '^FR[A-Z0-9]{4}[0-9]{3}') else true()" diagnostics="D26756-en">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ami (2nde lettre du symbolCode = 'F') alors le numéro d'obstacle doit suivre le masque suivant : FR puis alphanumérique sur 4 caractères puis numérique sur 3 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.H')) then matches(., '^ENY [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ennemi (2nde lettre du symbolCode = 'H') alors le numéro d'obstacle doit suivre le masque suivant : 'ENY ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[U]')) then matches(., '^UNK [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle inconnu ami (2nde lettre du symbolCode = 'U') alors le numéro d'obstacle doit suivre le masque suivant : 'UNK ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[FUH]')) then true() else false()">NC1_Obstacle.6: Le symbole code doit représenter soit un obstacle ami (2nde lettre du symbolCode = 'F') soit un obstacle ennemi (2nde lettre du symbolCode = 'H') soit un obstacle inconnu (2nde lettre du symbolCode = 'U').</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/tacticalData/bypassRouteId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26757-en">NC1_Obstacle.7: L'itinéraire de contournement de l'obstacle doit être un objet NC1_Route.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/obstacle/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26758-en">NC1_Obstacle.8: L'unité responsable de l'obstacle doit être une unité de l'Ordre de Bataille ami (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/location/endPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26856-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26862-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point d'arrivée doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point d'arrivée doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/location/startPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26855-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26861-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point de départ doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point de départ doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26860-en">NC1_Route.5: Le type de l'objet doit avoir pour valeur 38</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/location/endTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26858-en">NC1_Route.6: L'identifiant du point d'arrivée de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/location/startTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26857-en">NC1_Route.6: L'identifiant du point de départ de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/bypassRoute/location/segment/groundEntityId/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26859-en">NC1_Route.7: L'entité terrain représentant un tronçon d'itinéraire doit être une entité terrain (NC1_GroundEntity).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/facility/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($FacilityFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($FacilitySymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26358-en">NC1_Facility.1: Si la spécialisation Fr du code symbole est renseigné alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/facility/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26364-en">NC1_Facility.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26359-en">NC1_Facility.6: Lorsque l'installation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26362-en">NC1_Facility.9: La localisation d'une installation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Facility.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/facility/@id">
      <iso:assert test="matches(.,'^18:')" diagnostics="D26363-en">NC1_Facility.5: Le type de l'objet doit avoir pour valeur 18</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/facility/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26360-en">NC1_Facility.7: Le responsable de l'installation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/facility/medicalFacilityData/admittedIndividualId/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26361-en">NC1_Facility.8: La personne admise dans une installation médicale doit être un individu (NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1sitobst:NC1_SitObst/obstaclesAndWorks/groundEntity/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26789-en">NC1_GroundEntity.2: Le type de l'objet doit avoir pour valeur 20</iso:assert>
    </iso:rule>
    <iso:let name="ObstacleFrSpecific" value="doc('../Dictionnaires/ObstacleFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="ObstacleSymbol" value="doc('../Dictionnaires/ObstacleSymbolCode.gc')" />
    <iso:let name="FacilityFrSpecific" value="doc('../Dictionnaires/FacilityFrSpecificCode.gc')" />
    <iso:let name="FacilitySymbol" value="doc('../Dictionnaires/FacilitySymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26358-en">NC1_Facility.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26359-en">NC1_Facility.6: When the installation is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26360-en">NC1_Facility.7: The responsible of the 3D route shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26361-en">NC1_Facility.8: The person admitted in a medical installation has to be an individual ( NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26362-en">NC1_Facility.9: The location of the enemy facility shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26363-en">NC1_Facility.5: The type of the object has to have for value 18</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26364-en">NC1_Facility.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26754-en">NC1_Obstacle.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26755-en">NC1_Obstacle.5: When the obstacle is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26756-en">NC1_Obstacle.6: In the case of an enemy obstacle, that is the identity of which is worth « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » or « NONE SPECIFIED » (U, N, a Hour, J, K, or O in the APP6B), the number of obstacle on 9 characters has to begin with « ENY ».</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26757-en">NC1_Obstacle.7: The obstacle bypass route shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26758-en">NC1_Obstacle.8: The unit responsible for the obstacle shall be a unit of the Order of Battle (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26759-en">NC1_Obstacle.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26760-en">NC1_Obstacle.9: The location of the enemy obstacle shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26761-en">NC1_Obstacle.4: The type of the object has to have for value 17</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26789-en">NC1_GroundEntity.2: The type of the object has to have for value 20</iso:diagnostic>
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