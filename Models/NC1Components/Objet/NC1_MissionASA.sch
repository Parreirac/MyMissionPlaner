<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:missionASA" prefix="nc1missionASA" />
  <iso:pattern>
    <iso:title>NC1_MissionASA validation rules</iso:title>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26947-en">NC1_MissionASA.1: L'identifiant de l'unité ASA doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/batteryId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26948-en">NC1_MissionASA.2: L'identifiant de la batterie doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/priorityThreat/penetrationAxis/@id">
      <iso:assert test="matches(.,'^4[12]:')" diagnostics="D26949-en">NC1_MissionASA.4: L'identifiant de la zone particulière doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/implantationArea/airDefenceSectionId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26950-en">NC1_MissionASA.5: L'identifiant de la section ASA doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToDefend/unit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26951-en">NC1_MissionASA.6: L'identifiant de l'unité à défendre doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToDefend/unitHq/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26952-en">NC1_MissionASA.7: L'identifiant du PC de l'unité à défendre doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToEscort/unit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26953-en">NC1_MissionASA.8: L'identifiant de l'unité à escorter doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToEscort/unitHq/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26954-en">NC1_MissionASA.9: L'identifiant du PC de l'unité à escorter doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/elementToDefend/location/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26955-en">NC1_MissionASA.10: L'identifiant de la localisation de l'élément à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/surveillanceArea/proposedDeploymentArea/@id">
      <iso:assert test="matches(.,'^4[02]:')" diagnostics="D26956-en">NC1_MissionASA.11: L'identifiant de la zone de déploiement proposée doit être soit une surface tactique (NC1_TacArea) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/surveillanceArea/surveillanceArea/area/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26957-en">NC1_MissionASA.12: L'identifiant de la zone de surveillance doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/defenceArea/areaLocation/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26958-en">NC1_MissionASA.13: L'identifiant de la localisation de la zone à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/tacticalData/airDefenceUnitMission/airDefenceMission/defenceArea/elementToDefend/location/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26959-en">NC1_MissionASA.14: L'identifiant de la localisation de l'élément particulier à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1missionASA:NC1_MissionASA/@id">
      <iso:assert test="matches(.,'^56:')" diagnostics="D26960-en">NC1_MissionASA.15: Le type de l'objet doit avoir pour valeur 56.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26947-en">NC1_MissionASA.1: The ASA unit identifier must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26948-en">NC1_MissionASA.2: Battery ID must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26949-en">NC1_MissionASA.4: The identifier of the particular area must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26950-en">NC1_MissionASA.5: The identifier of the ASA section must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26951-en">NC1_MissionASA.6: The identifier of the unit to be defended must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26952-en">NC1_MissionASA.7: The PC identifier of the unit to be defended must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26953-en">NC1_MissionASA.8: The identifier of the unit to be escorted must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26954-en">NC1_MissionASA.9: The PC identifier of the unit to be escorted must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26955-en">NC1_MissionASA.10: The identifier of the location of the element to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26956-en">NC1_MissionASA.11: The identifier of the proposed deployment zone must be either a tactical surface (NC1_TacArea) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26957-en">NC1_MissionASA.12: The identifier of the surveillance zone must be a tactical surface (NC1_TacArea).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26958-en">NC1_MissionASA.13: The identifier of the location of the area to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26959-en">NC1_MissionASA.14: The identifier of the location of the particular element to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26960-en">NC1_MissionASA.15: The object type must be 56.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>