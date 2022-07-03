<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:medevac" prefix="nc1medevac" />
  <iso:pattern>
    <iso:title>NC1_MEDEVAC-NINE-LINE validation rules</iso:title>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupPoint/tacticalData/symbolCode">
      <iso:assert test="matches(.,':G.C.SPY')" diagnostics="D26522-en">NC1_MEDEVAC-NINE-LINE.2: Le point d'évacuation doit être un point de type « CASUALTY COLLECTION POINT » (CCP).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData">
      <iso:assert test="count(requestingUnitComData) + count(frequencyAndCallSign) &gt; 0" diagnostics="D26517-en">NC1_MEDEVAC-NINE-LINE.3: Les données de communication de l'unité demandeuse ou La Fréquence et indicatif doivent être renseignées.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupPoint">
      <iso:assert test="count(location) = 1" diagnostics="D26518-en">NC1_MEDEVAC-NINE-LINE.4: Le point d'évacuation doit être localisé.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/injuredToEvacuatePerPriority">
      <iso:assert test="urgentNumber + priorityNumber + routineNumber &gt; 0" diagnostics="D26519-en">NC1_MEDEVAC-NINE-LINE.5: Le nombre de blessés à évacuer toutes priorités confondues (urgent, prioritaire et routine) doit être supérieur à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/patientToEvacuateStretcherOrWalking">
      <iso:assert test="litterNumber + ambulatoryNumber + escortsNumber &gt; 0" diagnostics="D26520-en">NC1_MEDEVAC-NINE-LINE.6: Le nombre de patients à évacuer toutes positions confondues (allongé, assis et accompagnant) doit être supérieur à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupZoneAdditionalInformation">
      <iso:assert test="count(*) &gt; 0" diagnostics="D26521-en">NC1_MEDEVAC-NINE-LINE.7: Les informations supplémentaires sur la zone d'évacuation doivent être renseignées.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupZoneSpecialEquipments/type">
      <iso:assert test="if (none = true()) then hoist = false() and extrication = false() and ventilator = false() and not(other) else true()">NC1_MEDEVAC-NINE-LINE.10: Si la valeur de A - Rien est à vrai alors les valeurs de B - Treuillage, C - Désincarcération et D - Respirateur doivent être à faux et E - Autre ne doit pas être renseigné.</iso:assert>
      <iso:assert test="if ((hoist = true()) or (extrication = true()) or (ventilator = true()) or other) then none = false() else true()">NC1_MEDEVAC-NINE-LINE.10: Si l'une des valeurs de B - Treuillage ou C - Désincarcération ou D - Respirateur est à vrai ou si E - Autre est renseigné alors la valeur de A - Rien doit être à faux.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupZoneMarking/method/pannelsComment">
      <iso:assert test="../pannels = true()">NC1_MEDEVAC-NINE-LINE.14: Le commentaire pour l'utilisation d'un panneau pour la méthode de marquage utilisée ne peut être renseigné si la donnée A - Panneau est à Faux.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupZoneMarking/method/pyroComment">
      <iso:assert test="../pyro = true()">NC1_MEDEVAC-NINE-LINE.14: Le commentaire pour l'utilisation de la fusée éclairante pour la méthode de marquage utilisée ne peut être renseigné si la donnée B - Fusée éclairante est à Faux.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupZoneMarking/method/smokeComment">
      <iso:assert test="../smoke = true()">NC1_MEDEVAC-NINE-LINE.14: Le commentaire pour l'utilisation de fumigène pour la méthode de marquage utilisée ne peut être renseigné si la donnée C - Fumigène est à Faux.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/patientToEvacuatePerGroup/type">
      <iso:assert test="militaryCoalition + civilianWithCoalition + noCoalitionForces + noCoalitionCivilian + opposingForces + child &gt; 0">NC1_MEDEVAC-NINE-LINE.15: Les valeurs de "A - Force coalition", "B - Civils coalition", "C - Militaires ami", "D - Civils", "E - Prisonniers" et "F - Enfants" ne peuvent être toutes à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupPoint/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupPoint/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/pickupPoint/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1medevac:NC1_MEDEVAC-NINE-LINE/medicalEvacuationRequest/comData/requestingUnitComData/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:let name="TacPointSymbol" value="doc('../Dictionnaires/TacPointSymbolCode.gc')" />
    <iso:let name="TacPointFrSpecific" value="doc('../Dictionnaires/TacPointFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26517-en">NC1_MEDEVAC-NINE-LINE.3: Requesting unit communication data shall be set.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26518-en">NC1_MEDEVAC-NINE-LINE.4: The evacuation point shall be localized.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26519-en">NC1_MEDEVAC-NINE-LINE.5: The priority of the patient(s) to evacuate shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26520-en">NC1_MEDEVAC-NINE-LINE.6: At least one of the information « slept », « standing » or « accompanied » must be informed for the patient to evacuate.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26521-en">NC1_MEDEVAC-NINE-LINE.7: The pickup zone additional information shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26522-en">NC1_MEDEVAC-NINE-LINE.2: The point of evacuation has to be a point of « type CASUALTY COLLECTION » (CCP).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26829-en">NC1_TacPoint.5: The responsible of the tactical point shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26830-en">NC1_TacPoint.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26831-en">NC1_TacPoint.4: The type of the object has to have for value 40</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26832-en">NC1_TacPoint.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
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