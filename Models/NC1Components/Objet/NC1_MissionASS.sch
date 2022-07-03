<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:missionASS" prefix="nc1missionASS" />
  <iso:pattern>
    <iso:title>NC1_MissionASS validation rules</iso:title>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/executiveUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26961-en">NC1_MissionASS.1: L'identifiant de l'unité exécutante doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/groundUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26962-en">NC1_MissionASS.2: L'identifiant de l'unité de mêlée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA/fireUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26963-en">NC1_MissionASS.3: L'identifiant de l'unité chargée du tir doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA/registrationFireUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26964-en">NC1_MissionASS.4: L'identifiant de l'unité pour la mise en place doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/searchedEffect/supportUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26965-en">NC1_MissionASS.5: L'identifiant de l'unité appuyée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/superiorFieldArtilleryMission">
      <iso:assert test="count(searchedEffect) = count(distinct-values(searchedEffect))" diagnostics="D26966-en">NC1_MissionASS.7: Il ne peut pas y avoir 2 fois le même effet recherché lors de la mission feux du supérieur.</iso:assert>
      <iso:assert test="if (searchedEffect='12') then otherEffect else not(otherEffect)" diagnostics="D26967-en">NC1_MissionASS.8: La description des effets n'est renseignée que si dans la liste des effets recherchés lors de la mission du supérieur il y a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/searchedEffect">
      <iso:assert test="if (effectType='12') then otherEffect else not(otherEffect)" diagnostics="D26968-en">NC1_MissionASS.9: La description des effets n'est renseignée que si le type d'effet recherché a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiring/target">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26972-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission d'acquisition.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26970-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission au contact.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/indepthFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26971-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission dans la profondeur.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/superiorFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26969-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission du supérieur.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/target/objectiveForces/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26974-en">NC1_MissionASS.12: L'identifiant de l'objectif de type force doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/indepthFieldArtilleryMission/target/objectiveForces/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26973-en">NC1_MissionASS.12: L'identifiant de l'objectif de type force doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/contactFieldArtilleryMission/consumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26983-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26977-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission au contact.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/fireReinforcementMission/allocatedConsumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26982-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26976-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission de renforcement des feux.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/fireReinforcementMission/fireUnitDescription">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26980-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/indepthFieldArtilleryMission/consumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26981-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26975-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission dans la profondeur.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData">
      <iso:assert test="if (indepthFieldArtilleryMission/acquisitionMeans='16') then indepthFieldArtilleryMission/otherAcquisitionMeans else not(indepthFieldArtilleryMission/otherAcquisitionMeans)" diagnostics="D26978-en">NC1_MissionASS.16: La description d'un autre moyen d'acquisition n'est à renseigner que si le moyen d'acquisition de la mission dans la profondeur a la valeur "Autre".</iso:assert>
      <iso:assert test="if (acquiringFieldArtilleryMission or superiorFieldArtilleryMission) then not(comment) else true()" diagnostics="D26986-en">NC1_MissionASS.23: l’attribut "comment" est interdit lorsque "acquiringFieldArtilleryMission» est présent.</iso:assert>
      <iso:assert test="if (superiorFieldArtilleryMission or fireReinforcementMission or intelFieldArtilleryMission) then not(tacticalPhase) else true()" diagnostics="D26990-en">NC1_MissionASS.29: Le temps de manoeuvre ne doit pas être renseigné si la mission du supérieur ou la mission de renforcement feux ou la mission de renseignement est renseignée.</iso:assert>
      <iso:assert test="if (acquiringFieldArtilleryMission) then string-length(missionASSName)&lt;= 8 else true()" diagnostics="D26992-en">NC1_MissionASS.31: Le nom de la mission ne peut pas excéder 8 caractères si la mission d'acquisition est renseignée.</iso:assert>
      <iso:assert test="if (contactFieldArtilleryMission or indepthFieldArtilleryMission or acquiringFieldArtilleryMission/acquiringCOBRA) then levelOfConfirmation else not(levelOfConfirmation)" diagnostics="D26995-en">NC1_MissionASS.36: Le niveau de confirmation doit être renseigné si la mission au contact ou la mission dans la profondeur ou la mission d'acquisition hors COBRA est renseignée.</iso:assert>
      <iso:assert test="if (not(superiorFieldArtilleryMission) and not(acquiringFieldArtilleryMission)) then not(validityPeriod) else true()" diagnostics="D26996-en">NC1_MissionASS.37: La période de validité ne doit pas être renseignée si la mission du supérieur et la mission d'acquisition ne sont pas renseignées.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/intelFieldArtilleryMission/intelTask/searchedFact">
      <iso:assert test="count(observationType) = count(distinct-values(observationType))" diagnostics="D26979-en">NC1_MissionASS.19: Il ne peut pas y avoir 2 fois le même type d'observation au cours d'une action de la mission de renseignement.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/intelFieldArtilleryMission/intelTask/searchedFact/interestedAuthority/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26984-en">NC1_MissionASS.20: L'identifiant de l'autorité intéressée par le fait recherché de la mission de renseignement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/fireReinforcementMission/beneficialUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26985-en">NC1_MissionASS.21: L'identifiant de l'unité bénéficiaire de la mission de renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission">
      <iso:assert test="if (resourcesType!='1' and resourcesType!='10') then acquiring/coordinationUnit else true()" diagnostics="D26987-en">NC1_MissionASS.26: la formation de coordination de la mission d'acquisition est obligatoire si le type de moyen n'a pas la valeur EOP ni la valeur COBRA.</iso:assert>
      <iso:assert test="if (resourcesType='0' or resourcesType='3') then acquiring/rattachmentUnit else not(acquiring/rattachmentUnit)" diagnostics="D26988-en">NC1_MissionASS.27: la formation de rattachement de la mission d'acquisition est obligatoire si le type de moyen a la valeur EO ou EOA sinon elle est interdite.</iso:assert>
      <iso:assert test="if (resourcesType='0' or resourcesType='3' or resourcesType='10') then not(acquiring/target) else acquiring/target" diagnostics="D26989-en">NC1_MissionASS.28: l'objectif de la mission d'acquisition est interdit si le type de moyen a la valeur EO ou EOA ou COBRA sinon il est obligatoire.</iso:assert>
      <iso:assert test="if (resourcesType='10') then acquiringCOBRA else not(acquiringCOBRA)" diagnostics="D26998-en">NC1_MissionASS.39: Si le type de moyen de la mission d'acquisition a la valeur COBRA alors la partie mission d'acquisition COBRA doit être renseignée sinon elle ne doit pas l'être.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/indepthFieldArtilleryMission/effectByArea">
      <iso:assert test="if (searchedEffectType='12') then otherEffect else not(otherEffect)" diagnostics="D26991-en">NC1_MissionASS.30: Si l'effet recherché de la mission feux dans la profondeur a la valeur OTHER alors la donnée Autres effets doit être renseignée sinon elle ne doit pas être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/fireReinforcementMission/fireUnitDescription/unitType">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2) and matches(.,':...[AP]')" diagnostics="D26993-en">NC1_MissionASS.34: les 13ème et 14ème caractères du type d'unité doivent correspondre à une valeur du dictionnaire L105_2Code et le 4ème caractère doit valoir "A" ou "P".</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA">
      <iso:assert test="if (delegationFireIndicator='true' or delegationFireIndicator=1) then delegationFireNumber else not(delegationFireNumber)" diagnostics="D26994-en">NC1_MissionASS.35: Si l'indicateur pour la délégation de tir de la mission d'acquisition COBRA a la valeur VRAI alors la donnée Nombre de tirs délégués doit être renseignée sinon elle ne doit pas être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/beneficialUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26997-en">NC1_MissionASS.38: L'identifiant de l'unité bénéficiaire de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiring/coordinationUnit/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26999-en">NC1_MissionASS.40: L'identifiant de l'unité de la formation de coordination de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/acquiringFieldArtilleryMission/acquiring/rattachmentUnit/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D27000-en">NC1_MissionASS.40: L'identifiant de l'unité de la formation de rattachement de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/@id">
      <iso:assert test="matches(.,'^57:')" diagnostics="D27001-en">NC1_MissionASS.41: Le type de l'objet doit avoir pour valeur 57.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASS:NC1_MissionASS/tacticalData/intelFieldArtilleryMission/areaId/@id">
      <iso:assert test="matches(.,'^42:')">NC1_MissionASS.42: L'identifiant de la zone d'effort ou de priorité de la mission de renseignement doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26961-en">NC1_MissionASS.1: The identifier of the executing unit must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26962-en">NC1_MissionASS.2: The melee unit identifier must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26963-en">NC1_MissionASS.3: The identifier of the firing unit must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26964-en">NC1_MissionASS.4: The unit identifier for setting up must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26965-en">NC1_MissionASS.5: The identifier of the unit pressed must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26966-en">NC1_MissionASS.7: it's not possible to have the same searched effect in fire mission of superior</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26967-en">NC1_MissionASS.8: effects desscription is filled in only if in sought effect list in superior mission the value "other" is present..</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26968-en">NC1_MissionASS.9: The description of the effects is only filled in if the type of effect sought has the value "Other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26969-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the superior's mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26970-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the contact mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26971-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the mission in depth</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26972-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the acquisition mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26973-en">NC1_MissionASS.12: The identifier of the force type objective must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26974-en">NC1_MissionASS.12: The identifier of the force type objective must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26975-en">NC1_MissionASS.15: The value of the type of loading does not correspond to the values ??allowed by the category of the caliber for the mission in depth.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26976-en">NC1_MissionASS.15: The value of the load type does not correspond to the values ??allowed by the caliber category for the fire reinforcement mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26977-en">NC1_MissionASS.15: The load type value does not correspond to the values ??allowed by the caliber category for the contact mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26978-en">NC1_MissionASS.16: The description of another acquisition means must be filled in only if the acquisition means of the deep mission has the value "Other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26979-en">NC1_MissionASS.19: There cannot be twice the same type of observation during an action of the intelligence mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26980-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26981-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26982-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26983-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26984-en">NC1_MissionASS.20: The identifier of the authority interested in the fact sought from the intelligence mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26985-en">NC1_MissionASS.21: The identifier of the beneficiary unit of the reinforcement mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26986-en">NC1_MissionASS.23: attribute "comment" is forbidden when  "acquiringFieldArtilleryMission" is present.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26987-en">NC1_MissionASS.26: the coordination formation of the acquisition mission is mandatory if the type of means does not have the EOP value or the COBRA value.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26988-en">NC1_MissionASS.27: the attachment formation of the acquisition mission is mandatory if the type of means has the value EO or EOA otherwise it is prohibited.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26989-en">NC1_MissionASS.28: the objective of the acquisition mission is prohibited if the type of means has the value EO or EOA or COBRA otherwise it is mandatory.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26990-en">NC1_MissionASS.29: The maneuver time must not be filled in if the superior's mission or the fire reinforcement mission or the intelligence mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26991-en">NC1_MissionASS.30: If the desired effect of the deep fire mission has the value OTHER then the Other effects data item must be filled in otherwise it must not be filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26992-en">NC1_MissionASS.31: The name of the mission cannot exceed 8 characters if the acquisition mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26993-en">NC1_MissionASS.34: the 13th and 14th characters of the unit type must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26994-en">NC1_MissionASS.35: If the indicator for the firing delegation of the COBRA acquisition mission has the value TRUE then the number of delegated firing data must be filled in otherwise it must not be filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26995-en">NC1_MissionASS.36: The confirmation level must be filled in if the contact mission or the in-depth mission or the non-COBRA acquisition mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26996-en">NC1_MissionASS.37: the attachment formation of the acquisition mission is mandatory if the type of means has the value EO or EOA otherwise it is prohibited.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26997-en">NC1_MissionASS.38: The identifier of the beneficiary unit of the acquisition mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26998-en">NC1_MissionASS.39: If the type of means of the acquisition mission has the value COBRA then the COBRA acquisition mission part must be filled in otherwise it must not be.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26999-en">NC1_MissionASS.40: The unit identifier of the acquisition mission coordination formation must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D27000-en">NC1_MissionASS.40: The unit identifier of the formation of the acquisition mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D27001-en">NC1_MissionASS.41: The object type must be 57.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>