<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:conarep" prefix="nc1conarep" />
  <iso:pattern>
    <iso:title>NC1_ConARep validation rules</iso:title>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute">
      <iso:assert test="../convoy/movementData/routeId and @id=../convoy/movementData/routeId/@id" diagnostics="D26464-en">NC1_ConARep.2: L'itinéraire doit correspondre à celui renseigné dans l'objet NC1_Convoy (attribut « itinéraire »).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/convoy/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.SLC')" diagnostics="D26848-en">NC1_Convoy.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un convoi doit être dans la famille G*C*SLC******** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26854-en">NC1_Convoy.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26849-en">NC1_Convoy.7: Si le convoi est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26852-en">NC1_Convoy.10: La localisation d'un convoi ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Convoy.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/convoy/@id">
      <iso:assert test="matches(.,'^16:')" diagnostics="D26853-en">NC1_Convoy.6: Le type de l'objet doit avoir pour valeur 16</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/convoy/tacticalData/belongingAgentId/@id">
      <iso:assert test="matches(.,'^[0-8]:')" diagnostics="D26850-en">NC1_Convoy.8: Les membres d'un convoi doivent être des agents (NC1_Unit, NC1_Organisation ou NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/convoy/movementData/routeId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26851-en">NC1_Convoy.9: L'itinéraire associé au mouvement doit être un itinéraire (NC1_Route).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/location/endPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26856-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26862-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point d'arrivée doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point d'arrivée doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/location/startPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26855-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26861-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point de départ doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point de départ doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26860-en">NC1_Route.5: Le type de l'objet doit avoir pour valeur 38</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/location/endTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26858-en">NC1_Route.6: L'identifiant du point d'arrivée de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/location/startTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26857-en">NC1_Route.6: L'identifiant du point de départ de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/associatedRoute/location/segment/groundEntityId/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26859-en">NC1_Route.7: L'entité terrain représentant un tronçon d'itinéraire doit être une entité terrain (NC1_GroundEntity).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/event/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.O')" diagnostics="D26821-en">NC1_Event.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement doit être dans la famille G*O************ .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26828-en">NC1_Event.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) = 0 else true()" diagnostics="D26822-en">NC1_Event.6: Lorsque l'événement est anticipé, la qualité de la mesure de localisation ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26826-en">NC1_Event.9: La localisation d'un événement ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Event.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/event/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26827-en">NC1_Event.5: Le type de l'objet doit avoir pour valeur 30</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/event/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26825-en">NC1_Event.7: Le responsable de la gestion de l'événement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/event/tacticalData/initiatorEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26823-en">NC1_Event.8: L'acteur ayant provoqué l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/event/tacticalData/involvedEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26824-en">NC1_Event.8: L'acteur impliqué dans l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1conarep:NC1_ConARep/movementArrivalReport/reportingUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26464-en">NC1_ConARep.2: The route has to correspond to that informed in the object NC1_Convoy (attribute « route ») informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26821-en">NC1_Event.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an event has to be in the family G*O ************ .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26822-en">NC1_Event.6: When the event is anticipated, the location measurement quality shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26823-en">NC1_Event.8: The actor having caused the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26824-en">NC1_Event.8: The actor involved in the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26825-en">NC1_Event.7: The responsible of the management of the event shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26826-en">NC1_Event.9: The location of the enemy event shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26827-en">NC1_Event.5: The type of the object has to have for value 30</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26828-en">NC1_Event.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26848-en">NC1_Convoy.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a convoy has to be in the family G*C*SLC ******** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26849-en">NC1_Convoy.7: If the convoy is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26850-en">NC1_Convoy.8: The members of a convoy have to be agents (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26851-en">NC1_Convoy.9: The route associated to the movement shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26852-en">NC1_Convoy.10: The location of the enemy convoy shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26853-en">NC1_Convoy.6: The type of the object has to have for value 16</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26854-en">NC1_Convoy.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26855-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26856-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26857-en">NC1_Route.6: The route start point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26858-en">NC1_Route.6: The route end point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26859-en">NC1_Route.7: The ground entity associated to a route section shall be a NC1_GroundEntity object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26860-en">NC1_Route.5: The type of the object has to have for value 38</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26861-en">NC1_Route.4: The 13th and 14th characters of the Code of the starting point symbol must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26862-en">NC1_Route.4: The 13th and 14th characters of the Code of the symbol of the end point must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26863-en">NC1_Unit.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26864-en">NC1_Unit.9: When the unity(unit) is anticipated, the quality of the measure of location(localization) and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26865-en">NC1_Unit.12: For a link of organic subordination, i.e. equal to 5 (RATORG), the period of detachment should not be informed else the period of detachment must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26866-en">NC1_Unit.13: When the subordination type is provided, the superior unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26867-en">NC1_Unit.14: The unit's superior shall also be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26868-en">NC1_Unit.15: The operational or logistic status of the unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26869-en">NC1_Unit.2: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26870-en">NC1_Unit.16: The location of the enemy unit shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26871-en">NC1_Unit.8: For a non-friendly unit, only URN and STNL16 IDs shall be provided else only EISN and TNL16 IDs shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26872-en">NC1_Unit.7: The type of the object has to have for value 0</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26873-en">NC1_Unit.19: The "commandAndControlRole" attribute must not have the values ??'Unknown' and 'No statement' for units from DQP.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>