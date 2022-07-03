<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:objectivelist" prefix="nc1objectivelist" />
  <iso:pattern>
    <iso:title>NC1_ObjectiveList validation rules</iso:title>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList">
      <iso:assert test="if (fireObjectives/confirmationStatus=1) then @situation='STC' else true()" diagnostics="D26737-en">NC1_ObjectiveList.1: La situation de ce message doit être STC (Situation Tactique Courante) quand la liste est à l'état validée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective">
      <iso:assert test="if (../confirmationStatus=1) then @instance='STC' else true()" diagnostics="D26738-en">NC1_ObjectiveList.2: L'instance de l'objectif feux doit valoir STC (Situation Tactique Courante) quand la liste est à l'état validée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives">
      <iso:assert test="if (confirmationStatus=1) then count(fireObjective)=count(fireObjective/tacticalData/tno) else true()" diagnostics="D26739-en">NC1_ObjectiveList.3: Lorsque la liste est validée alors tous les objectifs feux doivent avoir un TNO renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective/location/polyline">
      <iso:assert test="count(point) = 2" diagnostics="D26740-en">NC1_FireObjective.1: La forme polyline doit comporter exactement 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26744-en">NC1_FireObjective.4: Le type de l'objet doit avoir pour valeur 36</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective/tacticalData/targetId/@id">
      <iso:assert test="matches(.,'^([0-9]|[1-2][0-9]|3[018]|4[0124]):')" diagnostics="D26741-en">NC1_FireObjective.5: L'objet NC1 pris pour objectif feux doit être au choix : un point tactique (NC1_TacPoint), une ligne tactique (NC1_TacLine), une surface tactique (NC1_TacArea), un événement (NC1_Event), un événement NRBC (NC1_CbrnEvent), une forme graphique libre (NC1_FreeShape), un itinéraire (NC1_Route), ou tout objet NC1 physique.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective/tacticalData/synchronizedFireId/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26742-en">NC1_FireObjective.6: L'objectif avec lequel une synchronisation est souhaitée doit être un objectif feux (NC1_FireObjective).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1objectivelist:NC1_ObjectiveList/fireObjectives/fireObjective/tacticalData">
      <iso:assert test="if (../@instance='STC') then count(tno)&gt;0 else count(name)+count(tno)&gt;0" diagnostics="D26743-en">NC1_FireObjective.7: L'objectif feux doit être identifié par son TNO (numéro d'objectif) si l'instance de l'objet est Situation Tactique Courante sinon il doit être identifié par son nom ou par son TNO.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26737-en">NC1_ObjectiveList.1: The context of this message owes being STC (Current Tactical Situation).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26738-en">NC1_ObjectiveList.2: The context of the objective fires has to be worth STC ( Current Tactical Situation) when the list is in the state validated..</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26739-en">NC1_ObjectiveList.3: When the list is validated then all the fire targets must have an entered TNO</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26740-en">NC1_FireObjective.1: The polyline shape must contain exactly 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26741-en">NC1_FireObjective.5: The possible NC1 object as a fire objective shall be one of the following: a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), an event (NC1_Event), a CBRN event (NC1_CbrnEvent), a free shape (NC1_FreeShape), a route (NC1_Route), or any physical NC1 object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26742-en">NC1_FireObjective.6: The objective with which a synchronization is wished has to be an objective fires (NC1_FireObjective).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26743-en">NC1_FireObjective.7: The objective fires must be identified by its TNO (number of objective) if the context of the object is Current Tactical Situation otherwise he must be identified by his name or by his TNO.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26744-en">NC1_FireObjective.4: The type of the object has to have for value 36</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>