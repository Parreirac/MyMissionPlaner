<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:reinforcement" prefix="nc1reinforcement" />
  <iso:pattern>
    <iso:title>NC1_Reinforcement validation rules</iso:title>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/@id">
      <iso:assert test="matches(.,'^53:')" diagnostics="D26736-en">NC1_Reinforcement.3: Le type de l'objet doit avoir pour valeur 53</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/tacticalData/givenUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26732-en">NC1_Reinforcement.4: L'unité donnée en renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/tacticalData/providingUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26733-en">NC1_Reinforcement.4: L'unité donnant le renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/tacticalData/reinforcedUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26734-en">NC1_Reinforcement.4: L'unité renforcée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/tacticalData/reinforcementId/@id">
      <iso:assert test="matches(.,'^53:')" diagnostics="D26735-en">NC1_Reinforcement.5: Le renforcement de référence doit être un renforcement (objet NC1_Reinforcement).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1reinforcement:NC1_Reinforcement/tacticalData/commandRelationshipCategory">
      <iso:assert test="not(.=0 or .=5)">NC1_Reinforcement.6: Le type de subordination tactique ne peut pas prendre les valeurs "COM" et "RATORG".</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26732-en">NC1_Reinforcement.4: The reinforcing unit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26733-en">NC1_Reinforcement.4: The unit providing the reinforcement shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26734-en">NC1_Reinforcement.4: The reinforced unit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26735-en">NC1_Reinforcement.5: The reference reinforcement shall be a reinforcement (NC1_Reinforcement).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26736-en">NC1_Reinforcement.3: The type of the object has to have for value 53</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>