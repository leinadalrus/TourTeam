<script setup lang="ts">
import CombatMapInsets from "./components/tables/CombatMapInsets.vue"
import DivisionStaff from "./components/staff/DivisionStaff.vue"
import TradingCard from "./components/cards/TradingCard.vue"
</script>

<template>
  <main>
    <CombatMapInsets />
    <div>
      <!-- TODO: `defineProps({})` method in: "DivisionStaff" -->
      <DivisionStaff v-for="members in post" :key="members.divisionCommander.uuid">
        <!--
          TODO: `defineProps({})` method in: "TradingCard" must be in v-bind-
          -to be passed as dynamic value(s) 
         -->
        <TradingCard :flagship={members.divisionCommander.division} />
      </DivisionStaff>
    </div>
  </main>
</template>

<style scoped lang="scss"></style>

